var dataTable;

$(document).ready(function () {
    loadDataTable();
    
})

function loadDataTable() {

    dataTable = $('#tblData').DataTable({
        "processing": true, // for show progress bar    
        "serverSide": true, // for process server side    
        "filter": true, // this is for disable filter (search box)    
        "orderMulti": false, // for disable multiple column at once    
        "ajax": {
            "url": "/Admin/Product/GetAll",

        },
        "columnDefs": [{
            "targets": [0],
            "visible": false,
            "searchable": false
        }],
        "columns": [
            { "data": "id", "autoWidth": true },
            { "data": "title", "autoWidth": true },
            { "data": "isbn", "autoWidth": true },
            { "data": "price", "autoWidth": true },
            { "data": "author", "autoWidth": true },
            { "data": "category.name", "autoWidth": true },
            {
                "data": "id",
                "render": function (data) {










                    return `
                <div class="btn-group w-75" role="group">
                    <a href="/Admin/Product/Upsert?id=${data}" class="btn btn-primary mx-2 btn-sm"><i class="bi bi-pencil-square"></i> Edit</a>
                    <a asp-controller="Category" asp-action="Delete" asp-route-id="@item.Id" class="btn btn-danger mx-2 btn-sm"><i class="bi bi-trash3-fill"></i> Delete</a>
                </div>`
                },
                "autoWidth": true
            }
           ] 

           
    });


}