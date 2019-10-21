
var userCustomer = {
    init: function () {
        userCustomer.registerEvents();
    },
    registerEvents: function () {
        $('.btn-active-tele').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id');
            $.ajax({
                url: "/Admin/User/ChangeStatus",
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    console.log(response);
                    if (response.status == true) {
                        btn.html('<strong>Active</strong>');
                    }
                    else {
                        btn.text('No Active');
                    }
                }
            });
        });
    }
}
userCustomer.init();