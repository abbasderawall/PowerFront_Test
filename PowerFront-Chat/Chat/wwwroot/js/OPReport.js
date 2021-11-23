var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/OPReport/Home/GetAll"
        },
        "columns": [
            { "data": "OperatorID", "width": "15%" },
            { "data": "Name", "width": "15%" },
            { "data": "ProactiveSent", "width": "15%" },
            { "data": "ProactiveAnswered", "width": "15%" },
            { "data": "ProactiveResponseRate", "width": "15%" },
            { "data": "ReactiveReceived", "width": "15%" },
            { "data": "ReactiveAnswered", "width": "15%" },
            { "data": "ReactiveResponseRate", "width": "15%" },
            { "data": "TotalChatLength", "width": "15%" },
            { "data": "AverageChatLength", "width": "15%" },
            
        ]
    });
}