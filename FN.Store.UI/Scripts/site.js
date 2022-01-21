$(function () {

    var dialogModalElement = $("#dialogModal")

    $('button[data-toggle="ajax-modal"]').click(function (event) {

        var url = $(this).data('url')
        $.get(url).done(function (data) {
            dialogModalElement.html(data)
            dialogModalElement.find('.modal').modal('show')
        })
    })

});