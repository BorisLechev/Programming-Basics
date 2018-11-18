function addProduct() {
    let product = $("input[type='text']").val();
    let price = +$("input[type='number']").val();

    if (product !== "" && price) {
        $("#product-list")
            .append($("<tr>")
                .append($(`<td>${product}</td>`))
                .append($(`<td>${price}</td>`)));

        let guestCheck = $("#bill tfoot tr td").eq(1);  // $("#bill tfoot tr td:nth-child(2)")
        let currentTotal = +guestCheck.text();
        let total = currentTotal + +price;

        guestCheck.text(total);

        $("input[type='text']").val("");
        $("input[type='number']").val("");
    }
}