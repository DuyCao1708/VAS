$(document).ready(function () {
    $('#dataTable').DataTable({
        "language":
        {
            "decimal": "",
            "emptyTable": "Không có dữ liệu về nguyên vật liệu",
            "info": "Hiển thị _START_ đến _END_ của _TOTAL_ nguyên vật liệu ",
            "infoEmpty": "Hiển thị 0 to 0 of 0 nguyên vật liệu",
            "infoFiltered": "(Lọc từ _MAX_ nguyên vật liệu)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Hiển thị  _MENU_  nguyên vật liệu",
            "loadingRecords": "Đang tải...",
            "processing": "",
            "search": "",
            "searchPlaceholder": "Tìm kiếm",
            "zeroRecords": "Không có nguyên vật liệu nào được tìm thấy",
            "paginate": {
                "first": "Đầu",
                "last": "Cuối",
                "next": "Sau",
                "previous": "Trước"
            },
            "aria": {
                "sortAscending": ": Sắp xếp theo thứ tự tăng dần",
                "sortDescending": ": Sắp xếp theo thứ tự giảm dần"
            }
        },
        pagingType: "simple_numbers"
    })
});

$(document).ready(function () {
    var table = $('#inventory-datatable').DataTable({
        language:
        {
            "decimal": "",
            "emptyTable": "Không có dữ liệu về nguyên vật liệu",
            "info": "Hiển thị _START_ đến _END_ của _TOTAL_ nguyên vật liệu ",
            "infoEmpty": "Hiển thị 0 to 0 of 0 nguyên vật liệu",
            "infoFiltered": "(Lọc từ _MAX_ nguyên vật liệu)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Hiển thị  _MENU_  nguyên vật liệu",
            "loadingRecords": "Đang tải...",
            "processing": "",
            "search": "",
            "searchPlaceholder": "Tìm kiếm",
            "zeroRecords": "Không có nguyên vật liệu nào được tìm thấy",
            "paginate": {
                "first": "Đầu",
                "last": "Cuối",
                "next": "Sau",
                "previous": "Trước"
            },
            "aria": {
                "sortAscending": ": Sắp xếp theo thứ tự tăng dần",
                "sortDescending": ": Sắp xếp theo thứ tự giảm dần"
            }
        },

        pagingType: "simple_numbers",

        rowReorder: true,
        rowReorder: {
            selector: 'tr'
        },
        columnDefs: [
            {
                target: 0,
                visible: false,
                searchable: false,
            },
            {
                orderable: false, targets: [3, 4, 5, 6, 7, 8]
            }],

    });
    table.on('order.dt search.dt', function () {
        let i = 1;

        table.cells(null, 0, { search: 'applied', order: 'applied' }).every(function (cell) {
            this.data(i++);
        });
    }).draw();
});
 
$(document).ready(function () {
    $('#danhmucvattu-datatable').DataTable({
        language:
        {
            "decimal": "",
            "emptyTable": "Không có dữ liệu về vật tư",
            "info": "Hiển thị _START_ đến _END_ của _TOTAL_ vật tư ",
            "infoEmpty": "Hiển thị 0 to 0 of 0 vật tư",
            "infoFiltered": "(Lọc từ _MAX_ vật tư)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Hiển thị  _MENU_  vật tư",
            "loadingRecords": "Đang tải...",
            "processing": "",
            "search": "",
            "searchPlaceholder": "Tìm kiếm",
            "zeroRecords": "Không có vật tư nào được tìm thấy",
            "paginate": {
                "first": "Đầu",
                "last": "Cuối",
                "next": "Sau",
                "previous": "Trước"
            },
            "aria": {
                "sortAscending": ": Sắp xếp theo thứ tự tăng dần",
                "sortDescending": ": Sắp xếp theo thứ tự giảm dần"
            }
        },
        columnDefs: [
            {
                orderable: false, targets: [1, 2, 3, 4, 6]
            }
        ],
        pagingType: "simple_numbers"
    })
});

$(document).ready(function () {
    $('#cuahangvattu-datatable').DataTable({
        language:
        {
            "decimal": "",
            "emptyTable": "Không có dữ liệu về vật tư",
            "info": "Hiển thị _START_ đến _END_ của _TOTAL_ vật tư ",
            "infoEmpty": "Hiển thị 0 to 0 of 0 vật tư",
            "infoFiltered": "(Lọc từ _MAX_ vật tư)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Hiển thị  _MENU_  vật tư",
            "loadingRecords": "Đang tải...",
            "processing": "",
            "search": "",
            "searchPlaceholder": "Tìm kiếm",
            "zeroRecords": "Không có vật tư nào được tìm thấy",
            "paginate": {
                "first": "Đầu",
                "last": "Cuối",
                "next": "Sau",
                "previous": "Trước"
            },
            "aria": {
                "sortAscending": ": Sắp xếp theo thứ tự tăng dần",
                "sortDescending": ": Sắp xếp theo thứ tự giảm dần"
            }
        },
        columnDefs: [
            {
                orderable: false, targets: [1, 2, 3, 4]
            }
        ],
        pagingType: "simple_numbers"
    })
});



       
 