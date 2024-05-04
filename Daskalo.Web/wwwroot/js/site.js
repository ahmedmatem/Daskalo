const message = function () {
    toastr.options = {
        "closeButton": false,
        "debug": false,
        "newestOnTop": true,
        "progressBar": false,
        "positionClass": "toast-top-center",
        //"positionClass": "toast-top-full-width",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }

    const success = function (message) {
        toastr["success"](message)
    }

    const error = function (message) {
        toastr["error"](message)

    }

    const info = function (message) {
        toastr["info"](message)
    }

    const warning = function (message) {
        toastr["warning"](message)

    }

    return { success, error, info, warning }
}()
