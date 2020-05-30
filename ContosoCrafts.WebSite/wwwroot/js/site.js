// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

// Bar chart
new Chart(document.getElementById("bar-chart"), {
    type: 'bar',
    data: {
        labels: ["5/25/20", "5/26/20", "5/27/20", "5/28/20", "5/29/20"],
        datasets: [
            {
                label: "Furniture",
                backgroundColor: "#3e95cd",
                data: [12, 17, 20, 15, 6]
            }, {
                label: "Lighting",
                backgroundColor: "#e55b48",
                data: [16, 7, 26, 14, 21]
            }, {
                label: "Books",
                backgroundColor: "#98De4e",
                data: [3, 6, 5, 7, 4]
            }, {
                label: "Electronics",
                backgroundColor: "#bc95ce",
                data: [5, 6, 8, 3, 13]
            }, {
                label: "Decorations",
                backgroundColor: "#efdc69",
                data: [16, 22, 13, 18, 15]
            }, {
                label: "Office Goods",
                backgroundColor: "#f368e4",
                data: [27, 31, 15, 19, 29]
            }
        ]
    },
    options: {
        legend: { display: true },
        title: {
            display: true,
            text: 'Items Claimed By Category: 5/25/20 to 5/29/20'
        }
    }
});


function startTime() {
    var today = new Date();
    var h = today.getHours();
    var m = today.getMinutes();
    var s = today.getSeconds();
    m = checkTime(m);
    s = checkTime(s);
    document.getElementById('txt').innerHTML =
        h + ":" + m + ":" + s;
    var t = setTimeout(startTime, 500);
}
function checkTime(i) {
    if (i < 10) { i = "0" + i };  // add zero in front of numbers < 10
    return i;
}
