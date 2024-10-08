﻿var dataTable

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tbtCompanyData').DataTable({
        "ajax": {
            url: '/admin/company/getall',
            dataSrc: function (json) {
                console.log(json);  // In ra dữ liệu từ API
                return json.data || [];
            }
        },
        "columns": [
            { data: 'id', "width": "5%" },
            { data: 'name', "width": "15%" },
            { data: 'industry', "width": "15%" },
            { data: 'email', "width": "15%" },
            { data: 'phone', "width": "15%" },
            { data: 'website', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class = "w-75 btn-group" role="group"> 
                    <a href="/admin/company/update?id=${data}" class="btn btn-sm btn-warning mx-1">
                        <i class="fa-solid fa-pen-to-square"></i> Edit
                    </a>
                    <a onClick=Delete('/admin/company/hidden/${data}')  class="btn btn-sm btn-danger mx-1">
                        <i class="fa-solid fa-trash"></i> Delete
                    </a>
                    </div>`;
                },
                "width": "15%"
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'PUT',
                success: function (data) {
                    dataTable.ajax.reload();
                    toast.success(data.message)
                }
            })

        
        }
    });
}