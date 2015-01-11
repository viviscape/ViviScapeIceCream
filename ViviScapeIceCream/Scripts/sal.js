


var sal = {

    baseurl: "/apiservice.svc/",
    getActiveFlavors: function (callback) {

        $.ajax({
            url: this.baseurl + "getActiveFlavors",
            data:{},
            dataType: "jsonp"

        }).done(function (results) {

            callback(results);
        });

    }
    


}