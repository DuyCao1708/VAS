$('#ddlPhanloai').editableSelect({
    filter: false,
});
$('#ddlPhanloai').attr("placeholder", "--Chọn phân loại--");

$('#ddlQuychuan').editableSelect({
    filter: true,
});
$('#ddlQuychuan').attr("placeholder", "--Chọn quy chuẩn--");

$('#ddlChungloai').editableSelect({
    filter: true,
});
$('#ddlChungloai').attr("placeholder", "--Chọn chủng loại--");

$('#ddlDonvi').editableSelect({
    filter: true,
});
$('#ddlDonvi').attr("placeholder", "--Chọn đơn vị tính--");