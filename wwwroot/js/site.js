// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var toggler = document.getElementsByClassName("caret");
var i;
var tableLanguage = {
    processing: "Đang thực thi...",
    search: "Tìm kiếm",
    lengthMenu: "Hiển thị _MENU_ bản ghi",
    info: "Hiển thị _START_ đến _END_ trong tổng số _TOTAL_ bản ghi",
    infoEmpty: "Hiển thị 0 đến 0 trong tổng số 0 bản ghi",
    infoFiltered: "(được lọc từ tổng số _MAX_ bản ghi)",
    infoPostFix: "",
    loadingRecords: "Chargement en cours...",
    zeroRecords: "Không có bản ghi để hiển thị",
    emptyTable: "Không có dữ liệu nào trong bảng",
    paginate: {
        first: "Trang đầu",
        previous: "Trước",
        next: "Sau",
        last: "Trang cuối"
    },
    aria: {
        sortAscending: ": sắp xếp cột theo thứ tự tăng dần",
        sortDescending: ": sắp xếp cột theo thứ tự giảm dần"
    }
}

for (i = 0; i < toggler.length; i++) {
    toggler[i].addEventListener("click", function () {
        let classList = this.parentElement.querySelector(".nested").classList
        if (classList) {
            this.parentElement.querySelector(".nested").classList.toggle("nested__active");
        }
    });
}

$(document).ready(function () {
    $('#catalogTable').DataTable({
        language: tableLanguage,
        dom: 'lrtip',
        fixedHeader: true,
        scrollX: true
    })

    $('#dataTable').DataTable({
        language: tableLanguage,
        dom: 'flrtip',
        fixedHeader: true,
        scrollX: true
    });
    $('#reportTable').DataTable({
        language: tableLanguage,
        dom: 'Bflrtip',
        buttons: [
            'excel',
            'pdf',
            'print'
        ],
        fixedHeader: true,
        scrollX: true
    });
});