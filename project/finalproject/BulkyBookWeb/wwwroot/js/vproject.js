var dataTable;





$(document).ready(function () {
    loadDataTable();
});





function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Vendor/Vendors/GetAll"
        },
        "columns": [
            { "data": "customer.name", "width": "15%" },
            { "data": "name", "width": "15%" },
            { "data": "description", "width": "15%" },
            { "data": "startDate", "width": "15%" },
            { "data": "endDate", "width": "15%" },
            { "data": "projectManager.name", "width": "15%" },
            { "data": "proposalSubmissionDate", "width": "15%" },
            { "data": "status", "width": "15%" },
            {
                "data": "pId",
                "render": function (data) {
                    return `
                        <div class="w-75 btn-group" role="group">
                        <a href="/Admin/Project/Upsert?pId=${data}"
                        class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                        <a href="/Admin/Project/Details?pId=${data}"
                        class="btn btn-success mx-2"> <i class="bi bi-pencil-square"></i> Details</a>
                        <a onClick=Delete('/Admin/Project/Delete/${data}')
                        class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>
                        `
                },
                "width": "15%"
            }
        ]
    });
}





function Delete(url) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    if (data.success) {
                        dataTable.ajax.reload();
                        toastr.success(data.message);
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }
    })
}