$.validator.methods.number = function (value, element) {
    return this.optional(element) || /^(?:\d{1,3})?(?:(\.|\,)\d{2})?$/.test(value);
};

$.validator.messages.number = "Please enter a valid number."; // Override the default error message