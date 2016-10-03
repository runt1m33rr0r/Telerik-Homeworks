function solve() {
    'use strict';

    var domElement = (function () {
        var emptyString = '',
            string = 'string',
            object = 'object',
            nonStringType = 'must be of type string!',
            typeString = 'Type',
            attributeNameString = 'Attribute name',
            typePattern = /^[A-Z0-9]+$/i,
            attributeNamePattern = /^[A-Z0-9\-]+$/i,
            invalidTypeCharacters = 'Type must contain only latin varters and digits!',
            invalidAttributeNameCharacters = 'Attribute name must contain only varters, digits and dashes!',
            nonExistingAttribute = 'Such attribute does not exist!',
            zero = 0;

        function validateIfString(value, propertyName) {
            if (typeof value !== string) {
                throw new Error(propertyName + ' ' + nonStringType);
            }
        }

        function validateType(type) {
            validateIfString(type, typeString);

            if (!typePattern.test(type)) {
                throw new Error(invalidTypeCharacters);
            }
        }

        function validateAttributeName(attributeName) {
            validateIfString(attributeName, attributeNameString);

            if (!attributeNamePattern.test(attributeName)) {
                throw new Error(invalidAttributeNameCharacters);
            }
        }

        function getSortedAttributeKeys(attributes) {
            var attributeKeys = [];

            for (var key in attributes) {
                attributeKeys.push(key);
            }

            return attributeKeys.sort();
        }

        function getAttributesString(attributes, sortedKeys) {
            var attributesString = emptyString;

            for (var i = 0; i < sortedKeys.length; i += 1) {
                var currentKey = sortedKeys[i];

                attributesString += ` ${currentKey}="${attributes[currentKey]}"`;
            }

            return attributesString;
        }

        function getChildrenString(children) {
            var childrenString = emptyString;

            for (var i = 0; i < children.length; i += 1) {
                var child = children[i];

                if (typeof child === object) {
                    childrenString += child.innerHTML;
                } else {
                    childrenString += child;
                }
            }

            return childrenString;
        }

        function checkIfAttributeExists(attributes, attributeName) {
            if (!attributes[attributeName]) {
                throw new Error(nonExistingAttribute);
            }
        }

        var domElement = {};

        Object.defineProperty(domElement, 'init', {
            value: function (type) {
                this.type = type;
                this.content = emptyString;
                this.parent = {};
                this.children = [];
                this.attributes = [];

                return this;
            }
        });

        Object.defineProperty(domElement, 'type', {
            get: function () {
                return this._type;
            },
            set: function (value) {
                validateType(value);
                this._type = value;
            }
        });

        Object.defineProperty(domElement, 'content', {
            get: function () {
                if (this.children.length) {
                    return emptyString;
                } else {
                    return this._content;
                }
            },
            set: function (value) {
                this._content = value;
            }
        });

        Object.defineProperty(domElement, 'attributes', {
            get: function () {
                return this._attributes;
            },
            set: function (value) {
                this._attributes = value;
            }
        });

        Object.defineProperty(domElement, 'children', {
            get: function () {
                return this._children;
            },
            set: function (value) {
                this._children = value;
            }
        });

        Object.defineProperty(domElement, 'parent', {
            get: function () {
                return this._parent;
            },
            set: function (value) {
                this._parent = value;
            }
        });

        Object.defineProperty(domElement, 'innerHTML', {
            get: function () {
                var innerHtml = '<' + this.type;
                var sortedAttributeKeys = getSortedAttributeKeys(this.attributes);
                var attributesString = getAttributesString(this.attributes, sortedAttributeKeys);
                var childrenString = getChildrenString(this.children);

                innerHtml += attributesString + '>' + childrenString + this.content + '</' + this.type + '>';
                return innerHtml;
            }
        });


        Object.defineProperty(domElement, 'appendChild', {
            value: function (child) {
                if (typeof child === object) {
                    child.parent = this;
                }

                this.children.push(child);
                return this;
            }
        });

        Object.defineProperty(domElement, 'addAttribute', {
            value: function (name, value) {
                validateAttributeName(name);
                this.attributes[name] = value;
                return this;
            }
        });

        Object.defineProperty(domElement, 'removeAttribute', {
            value: function (attribute) {
                checkIfAttributeExists(this.attributes, attribute);
                delete this.attributes[attribute];
                return this;
            }
        });

        return domElement;
    } ());

    return domElement;
}

module.exports = solve;
