$(document).ready(function () {

    var grandTotal = 0;
    var countRowsGenerics = 0;
    $('#quantity').on('keypress', function (event) {
        if (event.keyCode < 45 || event.keyCode > 57) return false;
    });

    $('#unit_price').on('keypress', function (event) {
        if (event.keyCode < 45 || event.keyCode > 57) return false;
    });

    $("#addSale").click(function (event) {
        let customer = $("#customer_dummy").val().toUpperCase();
        let payment = $("#payment_dummy").val().toUpperCase();
        let article = $("#article").val();
        let quantity = $("#quantity").val();
        let unit_price = $("#unit_price").val();
        let total = 0;

        if (customer == '' || article == '' || quantity == "" || unit_price == "" || payment == "") {
            alert("Favor de llenar todos los datos");
            return false;
        }

        $("#customer").val(customer);
        $("#payment").val(payment);
        total = quantity * unit_price;
        countRowsGenerics++;
        let field = `<tr id="${countRowsGenerics}">
        		        <input type="hidden" name="pos[]" id="pos*${countRowsGenerics}" value="${countRowsGenerics}"/>
                        <td>${countRowsGenerics}</td>
                        <input type="hidden" name="article[]" id="article*${countRowsGenerics}" value="${article}"/>
                        <td>${article}</td>
                        <input type="hidden" name="quantity[]" id="quantity*${countRowsGenerics}" value="${quantity}"/>
                        <td>${quantity}</td>
                        <input type="hidden" name="unit_price[]" id="unit_price*${countRowsGenerics}" value="${unit_price}"/>
                        <td>$ ${unit_price}</td>
                        <input type="hidden" name="total[]" id="total*${countRowsGenerics}" value="${total}"/>
                        <td>$ ${total}</td>
                        <td>
                            <button class="btn btn-primary btn_orders_remove" type="button" data-id="${countRowsGenerics}">Quitar</button>
                        </td>
                    </tr>`;
        grandTotal += total;
        let html_tr_element = document.createElement("tr");
        html_tr_element.innerHTML = field;
        document.getElementById("articlesOnSale").appendChild(html_tr_element);
        $("#grandTotal").html(grandTotal);
        $("#grandTotalOfSale").val(grandTotal);
    });

    $("#articlesOnSale").on("click", ".btn_orders_remove", function () {
        let id = $(this).attr("data-id");
        let total = document.getElementById("total*" + id).value;
        grandTotal = grandTotal - total;
        $(this).parent().parent().remove();
        $("#grandTotal").html(grandTotal);
        $("#grandTotalOfSale").val(grandTotal);
    });

});