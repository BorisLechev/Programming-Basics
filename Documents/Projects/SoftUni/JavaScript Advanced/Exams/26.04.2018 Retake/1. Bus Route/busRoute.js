function busRoute() {
    let firstBusStop = $('input[name="first-stop"]');
    let lastBusStop = $('input[name="last-stop"]');
    let firstAsNumber = firstBusStop.val();
    let lastAsNumber = lastBusStop.val();
    let allBusStops = $("#bus-stops li");

    if (firstAsNumber > 0 && lastAsNumber <= allBusStops.length && firstAsNumber < lastAsNumber) {
        $("#selected-route span").text(`${firstAsNumber}-${lastAsNumber}`);
        $("#selected-bus-stops").empty();

        for (let i = firstAsNumber; i <= lastAsNumber; i++) {
            $("#selected-bus-stops")
                .append($("<li>")
                    .text($(allBusStops[i - 1]).text()));
        }

        firstAsNumber = firstBusStop.val("");
        lastAsNumber = lastBusStop.val("");
    }
}

$(() => {
    let busStops = [
        "Gen. Gurko St.",
        "Sofia University",
        "Eagles' Bridge Sq.",
        "Bulgarian News Agency",
        "Peyo Yavorov Blvd.",
        "Aleksandar Zhendov Bvld.",
        // You can add/remove bus stops from here
    ];

    let listBusStops = $('#bus-stops');

    for (let i = 0; i < busStops.length; i++) {
        const busStopLi = $('<li>').text(busStops[i]);

        listBusStops.append(busStopLi)
    }
});