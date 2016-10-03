function solve() {
    'use strict';

    var Person = (function () {
        var minAge = 3,
            maxAge = 150,
            namePattern = /^[A-Za-z]{3,20}$/,
            invalidName = 'Name must contains only latin letters and has a length between 3 and 20 symbols!',
            invalidAgeType = 'Age must be a valid number!',
            invalidAgeRange = 'Age must be between 3 and 150!',
            whiteSpace = ' ';

        function validateName(name) {
            if (!namePattern.test(name)) {
                throw new Error(invalidName);
            }
        }

        function validateAge(age) {
            if (isNaN(age)) {
                throw new Error(invalidAgeType);
            } else {
                age = Number(age);

                if (age < minAge || age > maxAge) {
                    throw new Error(invalidAgeRange);
                }
            }
        }

        function Person(firstname, lastname, age) {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        Object.defineProperty(Person.prototype, 'firstname', {
            get: function () {
                return this._firstname;
            },
            set: function (value) {
                validateName(value);
                this._firstname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function () {
                return this._lastname;
            },
            set: function (value) {
                validateName(value);
                this._lastname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get: function () {
                return this._age;
            },
            set: function (value) {
                validateAge(value);
                this._age = Number(value);
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function () {
                return this.firstname + ' ' + this.lastname;
            },
            set: function (value) {
                var fullnameTokens = value.split(whiteSpace);

                this.firstname = fullnameTokens[0];
                this.lastname = fullnameTokens[1];
            }
        });

        Person.prototype.introduce = function () {
            return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
        };

        return Person;
    } ());

    return Person;
}

module.exports = solve;