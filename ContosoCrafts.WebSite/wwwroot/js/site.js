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
            }
        ]
    },
    options: {
        legend: { display: false },
        title: {
            display: true,
            text: 'Items Claimed By Category: 5/25/20 to 5/29/20'
        }
    }
});