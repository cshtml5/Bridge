    Bridge.assembly("System", {}, function ($asm, globals) {
        "use strict";

        Bridge.define("System.Uri", {
            statics: {
                methods: {
                    equals: function (uri1, uri2) {
                        if (uri1 == uri2) {
                            return true;
                        }

                        if (uri1 == null || uri2 == null) {
                            return false;
                        }

                        return uri2.equals(uri1);
                    },

                    notEquals: function (uri1, uri2) {
                        return !System.Uri.equals(uri1, uri2);
                    }
                }
            },

            ctor: function (uriString) {
                this.$initialize();
                this.absoluteUri = uriString;
                this.originalString = uriString;
            },

            ctor: function (uriString, uriKind) {
                this.$initialize();
                this.absoluteUri = uriString;
                this.originalString = uriString;
                this.uriKind = uriKind;
            },

            getAbsoluteUri: function () {
                return this.absoluteUri;
            },

            getOriginalString: function () {
                return this.originalString;
            },

            toJSON: function () {
                return this.absoluteUri;
            },

            toString: function () {
                return this.absoluteUri;
            },

            equals: function (uri) {
                if (uri == null || !Bridge.is(uri, System.Uri)) {
                    return false;
                }

                return this.absoluteUri === uri.absoluteUri;
            }
        });
    }, true);
