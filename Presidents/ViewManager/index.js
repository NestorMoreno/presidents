var uri = 'api/president';

$(document).ready(function () {
   
    $.getJSON(uri)
        .done(function (data) {
            $.each(data, function (key, item) {
                $('#presidentsMainTable tr:last').after(formatItem(item));
            });
        });
});

function formatItem(item) {
    return '<tr><td>' + item.Name + '</td><td>' + item.Birthday + '</td><td>' + item.Age + '</td><td>' + item.BirthPlace + '</td></tr>';
}


function find() {
    $("#presidentsResultTable tr").empty();
    var name = $('#presidentName').val();
    $.getJSON(uri + '/' + name)
        .done(function (data) {
            if (data.length > 0) {
                $.each(data, function (key, item) {
                    $('#presidentsResultTable tr:last').after(formatItem(item));
                });
            }
            else {
                $('#presidentsResultTable tr:last').after(formatItem(data));
            }
        })
        .fail(function (jqXHR, textStatus, err) {
            $('#president').text('Error: ' + err);
        });
}