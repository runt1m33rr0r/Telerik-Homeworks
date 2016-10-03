function solve() {
    'use strict';

    var whitespace = ' ',
        zero = 0,
        one = 1,
        two = 2,
        string = 'string',
        namePattern = /^[A-Z][a-z]*$/,
        invalidTitleType = 'Title must be of type string!',
        titleInvalidWhitespaces = 'Title must not start or end with spaces!',
        titleInvalidSpacesCount = 'Title must not have consecutive spaces!',
        titleSpacesPattern = /[\s]{2,}/,
        titleInvalidLength = 'Title must have atleast one character!',
        invalidPresentationsType = 'Presentations must be of type array!',
        invalidPresentationsLength = 'Invalid presentations length!',
        invalidNameType = 'Name must be of type string!',
        emptyName = 'Name cannot be empty!',
        invalidNamesCount = 'Two names must be passed!',
        invalidNameCharacters = 'Name must contain only letters!',
        invalidIdType = 'Type of ID must be an integer!',
        invalidIdRange = 'ID must be greater than 0!',
        invalidResultsType = 'Exam results must be of type array!',
        invalidNumberType = 'must be of type number!',
        nonExistingStudent = 'There is not such student!',
        studentAlreadyExists = 'The same student already exists!';

    var validator = (function () {
        function validateTitle(title) {
            if (!title || typeof title !== string) {
                throw new Error(invalidTitleType);
            } else if (title[0] === whitespace || title[title.length - 1] === whitespace) {
                throw new Error(titleInvalidWhitespaces);
            } else if (titleSpacesPattern.test(title)) {
                throw new Error(titleInvalidSpacesCount);
            } else if (title.trim().length === zero) {
                throw new Error(titleInvalidLength);
            }
        }

        function validatePresentations(presentations) {
            if (presentations === null || !Array.isArray(presentations)) {
                throw new Error(invalidPresentationsType);
            } else if (presentations.length === zero) {
                throw new Error(invalidPresentationsLength);
            } else {
                presentations.forEach(function (title) { validateTitle(title); });
            }
        }

        function validateName(name) {
            if (name === null || typeof name !== string) {
                throw new Error(invalidNameType);
            } else if (name.trim().length === zero) {
                throw new Error(emptyName);
            } else {
                var names = name.split(' ');

                if (names.length !== two) {
                    throw new Error(invalidNamesCount);
                } else {
                    names.forEach(function (n) {
                        if (!namePattern.test(n)) {
                            throw new Error(invalidNameCharacters);
                        }
                    });

                    return {
                        firstname: names[0],
                        lastname: names[1]
                    };
                }
            }
        }

        function validateId(id, maxId) {
            if (id !== Number(id)) {
                throw new Error(invalidIdType);
            } else {
                id = Number(id);

                if (id < one || id > maxId) {
                    throw new Error(invalidIdRange);
                }
            }
        }

        function validateResultsType(results) {
            if (!Array.isArray(results)) {
                throw new Error(invalidResultsType);
            }
        }

        function validateNumber(value, valueName) {
            if (isNaN(value)) {
                throw new Error(`${valueName} ${invalidNumberType}`);
            }
        }

        function validateIfStudentExists(students, studentId) {
            studentId = Number(studentId);

            if (studentId < one || studentId > students.length) {
                throw new Error(nonExistingStudent);
            }
        }

        function validateUniqueStudents(results) {
            var sortedResults = results.sort(function (a, b) { return a.StudentID - b.StudentID; });

            for (var i = 1; i < results.length; i += 1) {
                if (results[i].StudentID === results[i - 1].StudentID) {
                    throw new Error(studentAlreadyExists);
                }
            }
        }

        return {
            validateTitle: validateTitle,
            validatePresentations: validatePresentations,
            validateName: validateName,
            validateId: validateId,
            validateResultsType: validateResultsType,
            validateNumber: validateNumber,
            validateIfStudentExists: validateIfStudentExists,
            validateUniqueStudents: validateUniqueStudents
        };
    } ());

    var course = (function () {
        var course = {};

        Object.defineProperty(course, 'init', {
            value: function (title, presentations) {
                this.title = title;
                this.presentations = presentations;
                this.students = [];

                return this;
            }
        });

        Object.defineProperty(course, 'title', {
            get: function () {
                return this._title;
            },
            set: function (value) {
                validator.validateTitle(value);
                this._title = value;
            }
        });

        Object.defineProperty(course, 'presentations', {
            get: function () {
                return this._presentations;
            },
            set: function (value) {
                validator.validatePresentations(value);
                this._presentations = value;
            }
        });

        Object.defineProperty(course, 'students', {
            get: function () {
                return this._students;
            },
            set: function (value) {
                this._students = value;
            }
        });

        Object.defineProperty(course, 'addStudent', {
            value: function (name) {
                var student = validator.validateName(name);

                student.id = this.students.length + one;
                this.students.push(student);
                return student.id;
            }
        });

        Object.defineProperty(course, 'getAllStudents', {
            value: function () {
                return this.students;
            }
        });

        Object.defineProperty(course, 'submitHomework', {
            value: function (studentID, homeworkID) {
                validator.validateId(studentID, this.students.length);
                validator.validateId(homeworkID, this.presentations.length);
                return this;
            }
        });

        Object.defineProperty(course, 'pushExamResults', {
            value: function (results) {
                validator.validateResultsType(results);

                for (var i = 0; i < results.length; i += 1) {
                    var currentStudent = results[i],
                        studentId = currentStudent.StudentID;

                    validator.validateNumber(studentId);
                    validator.validateNumber(currentStudent.score);
                    validator.validateIfStudentExists(this.students, studentId);
                    validator.validateUniqueStudents(results);
                    this.students[studentId - one] = currentStudent.score;
                }

                return this;
            }
        });

        Object.defineProperty(course, 'getTopStudents', {
            value: function () {
            }
        });

        return course;
    } ());

    return course;
}

module.exports = solve;
