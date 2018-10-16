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
    return '<tr><td>' + item.Name + '</td><td>' + formatDate(new Date(item.Birthday)) + '</td><td>' + item.Age + '</td><td>' + item.BirthPlace + '</td></tr>';
}

function formatDate(date) {
    var monthNames = [ "January", "February", "March","April", "May", "June", "July","August", "September", "October","November", "December"];
    var day = date.getDate();
    var monthIndex = date.getMonth();
    var year = date.getFullYear();

    return day + ' ' + monthNames[monthIndex] + ' ' + year;
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