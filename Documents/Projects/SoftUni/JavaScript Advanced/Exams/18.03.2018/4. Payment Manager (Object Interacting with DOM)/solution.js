class PaymentManager {
    constructor(title) {
        this.title = this.createElement(title);
    }

    render(id) {
        $(`#${id}`).append(this.table);
    }

    createElement(title) {
        let table = $("<table>");
        let caption=$(`<caption>${title} Payment Manager</caption>`);
        let thead=$(
            "<thead>\n" +
            "        <tr>\n" +
            "            <th class=\"name\">Name</th>\n" +
            "            <th class=\"category\">Category</th>\n" +
            "            <th class=\"price\">Price</th>\n" +
            "            <th>Actions</th>\n" +
            "        </tr>\n" +
            "   </thead>\n");

        let tbody=$("<tbody class='payments'>");
        let tr=$("<tr>");

        let name=$("<th class='name'>Name</th>");
        tr.append(name);

        let category=$("<th class='category'>Category</th>");
        tr.append(category);

        let price=$("<th class='price'>Price</th>");
        tr.append(price);


    }

}