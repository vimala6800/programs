var dataTable;





$(document).ready(function () {
    loadDataTable();
});





function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Project/GetAll1"
        },
        "columns": [
            { "data": "project.name", "width": "15%" },
            { "data": "customer.name", "width": "15%" },
            { "data": "jobTitle", "width": "15%" },
            { "data": "skillSet", "width": "15%" },
            { "data": "experience", "width": "15%" },
            { "data": "numberOfMonths", "width": "15%" },
            { "data": "startDate", "width": "15%" },
            { "data": "endDate", "width": "15%" },
            { "data": "numberOfResources", "width": "15%" },





            {
                "data": "id",
                "render": function (data) {
                    return `
                        
                        <div class="w-75 btn-group" role="group">
                        <a href="/Admin/Project/Details?id=${data}"
                        class="btn btn-success mx-2"> <i class="bi bi-pencil-square"> Edit</i></a>
                        <a href="/Admin/Project/PdDelete/${data}"
                        class="btn btn-danger mx-2"> <i class="bi bi-pencil-square"> Delete </i></a>
                      
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