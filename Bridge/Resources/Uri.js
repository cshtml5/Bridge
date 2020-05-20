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
        ctor: function (uriString, uriKind) {
            this.$initialize();
            if (uriKind === undefined) {
                uriKind = 1;
            }
            this.uriKind = uriKind;
            this.originalString = uriString;
            this.uri = document.createElement('a');
            this.uri.href = uriString;
        },
        getOriginalString: function () {
            return this.originalString;
        },
        getProtocol: function () {
            this.verifyAbsoluteUri();
            return this.uri.protocol.slice(0, -1);
        },
        getHostName: function () {
            this.verifyAbsoluteUri();
            return this.uri.hostname;
        },
        getSearch: function () {
            this.verifyAbsoluteUri();
            return this.uri.search;
        },
        getHash: function () {
            this.verifyAbsoluteUri();
            return this.uri.hash;
        },
        getPort: function () {
            this.verifyAbsoluteUri();
            return this.uri.port;
        },
        getPathName: function () {
            this.verifyAbsoluteUri();
            return this.uri.pathname;
        },
        getAbsoluteUri: function () {
            this.verifyAbsoluteUri();
            return this.uri.href;
        },
        setHref: function (uri) {
            this.uri.href = uri;
        },
        verifyAbsoluteUri: function () {
            if (this.uriKind != 1) {
                throw new System.InvalidOperationException.$ctor1("Uri is not absolute.");
            }
        },
        toJSON: function () {
            return this.uri.href;
        },
        toString: function () {
            return this.uri.href;
        },
        equals: function (uri) {
            if (uri == null || !Bridge.is(uri, System.Uri)) {
                return false;
            }
            return this.uri.href === uri.uri.href;
        }
    });
}, true);
