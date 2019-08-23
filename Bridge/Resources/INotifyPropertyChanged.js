Bridge.define("System.ComponentModel.INotifyPropertyChanged", {
    $kind: "interface"
});

Bridge.define("System.ComponentModel.PropertyChangedEventArgs", {
    fields: {
        propertyName: null
    },

    config: {
        properties: {
            PropertyName: {
                get: function () {
                    return this.propertyName;
                }
            }
        }
    },

    ctor: function (propertyName) {
        this.$initialize();
        this.propertyName = propertyName;
    }
});