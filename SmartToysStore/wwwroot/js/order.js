﻿var dataTable

$(document).ready(function () {
    var url = window.location.search;
    if (url.includes("inprocess")) {
        loadDataTable("inprocess")
    }
    else{
        if (url.includes("completed")) {
            loadDataTable("completed")
        }
        else{
            if (url.includes("pending")) {
                loadDataTable("pending")
            }
            else{
                if (url.includes("approved")) {
                    loadDataTable("approved")
                }
                else{
                    loadDataTable("all")
                }
            }
        }
    }
});

function loadDataTable(status){
    dataTable = $('#tblData').DataTable({
        "ajax": {url:'/admin/order/getall?status=' +status},
        "columns": [
        {data:'id', "width": "5%" },
        {data:'name', "width": "15%" },
        {
            data: 'orderDate',
            "width": "15%",
            "render": function (data) {
                var date = new Date(data);
                return date.toLocaleDateString() + ' ' + date.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' });
            }
        },
        {data:'phoneNumber',"width": "20%"}, 
        {data:'applicationUser.email',"width": "15%"}, 
        {data:'orderStatus',"width": "10%"},
        {data:'orderTotal',"width": "10%"},
        {
            data:'id',
            "render": function (data) {
                return `<div class="w-100 btn-group" role="group">
                            <a href="/admin/order/details?orderId=${data}" class="btn btn-primary mx-2">
                                <i class="bi bi-pencil-square"></i> Edit
                            </a>
                        </div>`
            },
            "width": "10%"
        }
        ]
    });
}