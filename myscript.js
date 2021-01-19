$(document).ready(function () {
    $("#btnGet").click(function () {
        $.ajax({
            url: 'https://jsonplaceholder.typicode.com/users/3',
            type: 'GET',
            dataType: 'json'
        })
            .done(function (data, status) {
                $("#formId").val(data.id);
                $("#formName").val(data.name);
                $("#formUsername").val(data.username);
                $("#formEmail").val(data.email);
                $("#formUrl").append("http://");
                $("#formUrl").val(data.website);
            });
    });
});   