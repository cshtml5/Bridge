    Bridge.define("System.ComponentModel.DataAnnotations.ValidationResult", {
        statics: {
            fields: {
                success: null
            }
        },
        fields: {
            _memberNames: null,
            _errorMessage: null
        },
        props: {
            MemberNames: {
                get: function () {
                    return this._memberNames;
                }
            },
            ErrorMessage: {
                get: function () {
                    return this._errorMessage;
                },
                set: function (value) {
                    this._errorMessage = value;
                }
            }
        },
        ctors: {
            $ctor1: function (errorMessage) {
                System.ComponentModel.DataAnnotations.ValidationResult.$ctor2.call(this, errorMessage, null);
            },
            $ctor2: function (errorMessage, memberNames) {
                this.$initialize();
                this._errorMessage = errorMessage;
                this._memberNames = memberNames || System.Array.init(0, null, System.String);
            },
            ctor: function (validationResult) {
                this.$initialize();
                if (validationResult == null) {
                    throw new System.ArgumentNullException.$ctor1("validationResult");
                }

                this._errorMessage = validationResult._errorMessage;
                this._memberNames = validationResult._memberNames;
            }
        },
        methods: {
            toString: function () {
                var $t;
                return ($t = this.ErrorMessage, $t != null ? $t : Bridge.toString(this));
            }
        }
    });
