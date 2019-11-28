(function ($) {
    $(function () {
        $(".DeleteCustomer").click(function () {
            var id = $(this).attr("id");
            if (confirm('Are you sure you want to delete this person has id: ' + id)) {
                $.ajax({
                    type: 'POST',
                    headers: {
                        "XSRF-TOKEN": $('input:hidden[name="__RequestVerificationToken"]').val()
                    },
                    dataType: 'json',
                    contentType: 'application/json; charset=utf-8',
                    url: '/Admin/Customer?handler=DeleteCustomer',
                    data: JSON.stringify({
                        Id: id
                    }),
                    success: function (respone) {
                        alert(respone);
                        location.reload();
                    }
                });
            }
        });
        $(".DetailCustomer").click(function () {
            var id = $(this).attr("id");
            // alert("Id1 " + id);
            $.ajax({
                type: 'GET',
                dataType: 'json',
                headers: {
                    "XSRF-TOKEN": $('input:hidden[name="__RequestVerificationToken"]').val()
                },
                contentType: 'application/json; charset=utf-8',
                url: '/Admin/Customer?handler=DetailCustomer',
                data: {
                    id: id
                },
                success: function (result) {
                    alert("Id2 " + result.Id);
                    $("#DetailCustomer-lastname").val(result.LastName);
                    $("#DetailCustomer-firstname").val(result.FirstName);
                    $("#DetailCustomer-birthday").val(result.Birthdate);
                    $("#DetailCustomer-phone").val(result.Phone);
                    $("#DetailCustomer-email").val(result.Email);
                    $("#DetailCustomer-address").val(result.Address.toString());
                    $("#DetailCustomer-status").val(result.Status);
                    $("#DetailCustomer-username").val(result.Account.Username);
                    $("#DetailCustomer-password").val(result.Account.Password);

                }
            });
        });
        $(".EditCustomer").click(function () {
            var id = $(this).attr("id");
            $.ajax({
                type: 'GET',
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                url: '/Admin/Customer?handler=EditCustomer',
                data: {
                    id: id
                },
                success: function (result) {
                    alert("Id2 " + result.Id);
                    $("#EditCustomer-id").val(result.Id);
                    $("#EditCustomer-lastname").val(result.LastName);
                    $("#EditCustomer-lastname").val(result.FirstName);
                    $("#EditCustomer-birthday").val(result.Birthdate);
                    $("#EditCustomer-phone").val(result.Phone);
                    $("#EditCustomer-email").val(result.Email);
                    $("#EditCustomer-address").val(result.Address.toString());
                    $("#EditCustomer-status").val(result.Status);
                    $("#EditCustomer-username").val(result.Account.Username);
                    $("#EditCustomer-password").val(result.Account.Password);

                }
            });
        });
        $("#btsubmitEditCustomer").click(function () {
            var id = $('#EditCustomer-id').val();
            var name = $("#EditCustomer-name").val();
            var address = $("#EditCustomer-address").val();
            event.preventDefault();
            // event.preventDefault() là để ngăn thằng form nó load lại trang ..
            $.ajax({
                type: 'POST',
                headers: {
                    "XSRF-TOKEN": $('input:hidden[name="__RequestVerificationToken"]').val()
                },
                dataType: 'json',
                contentType: 'application/json; charset=utf-8',
                url: '/Admin/Customer?handler=EditCustomer',
                data: JSON.stringify({
                    Id: id,
                    CustomerName: name,
                    Address: address
                }),
                success: function (respone) {
                    $('#EditCustomerForm').modal('hide');
                    alert(respone);
                    location.reload();
                },
                failure: function (result) {
                    alert("fail");
                }

            });
        });

    });
})(jQuery);