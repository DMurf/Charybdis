// This can definitely be improved, remove JQuery etc.

$('.barchart').each(function () {
    var chartLabels = $(this).data("labels");
    var chartValues = $(this).data("values");
    var ctx = this.getContext("2d");

    const data = {
        labels: chartLabels,
        datasets: [
            {
                data: chartValues,
                borderColor: ['#d53880', '#4c2c92', '#505a5f'],
                backgroundColor: ['#d53880', '#4c2c92', '#505a5f'],
            }
        ]
    };
    Chart.defaults.font.size = 16;
    Chart.defaults.font.family = 'GDS Transport,arial,sans-serif';
    new Chart(
        ctx,
        {
            type: 'bar',
            data: data,
            plugins: [ChartDataLabels],
            options: {
                categoryPercentage: 1,
                indexAxis: 'y',
                scales: {
                    x: {
                        min: 0,
                        max: 1,
                        ticks: {
                            format: {
                                style: 'percent'
                            },
                            callback: function (value) {
                                return value.toLocaleString('en-GB', { style: 'percent' });
                            },
                        }
                    },
                    y: {
                        display: true,
                        ticks: {
                            format: {
                                style: 'percent'
                            }
                        }
                    }
                },
                plugins: {
                    tooltip: {
                        enabled: false
                    },
                    legend: {
                        display: false
                    },
                    datalabels: {
                        color: 'white',
                        anchor: 'end', 
                        align: 'start',
                        formatter: function (value, context) {
                            return Number(value).toLocaleString('en-GB', { style: 'percent', maximumFractionDigits: 2 });
                        }
                    }
                }
            },
            responsive: true,

        }
    );
});

$('.rotchart').each(function () {
    var chartLabels = $(this).data("labels");
    var chartScale = $(this).data("scale");
    var chartValuesY1 = $(this).data("values-y1");
    var chartValuesY2 = $(this).data("values-y2");
    var chartValuesY3 = $(this).data("values-y3");

   
    var ctx = this.getContext("2d");

    const data = {
        labels: chartScale,
        datasets: [
            {
                label: chartLabels[0],
                data: chartValuesY1,
                borderColor: '#d53880',
                backgroundColor:'#d53880',
            },
            {
                label: chartLabels[1],
                data: chartValuesY2,
                borderColor: '#4c2c92', 
                backgroundColor: '#4c2c92', 
                borderDash: [5, 5],
            },
            {
                label: chartLabels[2],
                data: chartValuesY3,
                borderColor:  '#505a5f',
                backgroundColor: '#505a5f',
                borderDash: [5, 5],
            }
        ]
    };
    Chart.defaults.font.size = 16;
    Chart.defaults.font.family = 'GDS Transport,arial,sans-serif';
    new Chart(
        ctx,
        {
            type: 'line',
            data: data,
            plugins: [ChartDataLabels],
            options: {
                categoryPercentage: 1,
                indexAxis: 'x',
                layout: {
                    padding:0
                },
                scales: {
                    y: {
                        min: 0,
                        max: 1,
                        ticks: {
                            format: {
                                style: 'percent'
                            },
                            callback: function (value) {
                                return value.toLocaleString('en-GB', { style: 'percent' });
                            },
                        }
                    },
                    x: {
                        offset:true,
                        display: true,
                        ticks: {
                            format: {
                                style: 'percent'
                            }
                        }
                    }
                },
                plugins: {
                    tooltip: {
                        enabled: false
                    },
                    legend: {
                        position: 'bottom',
                        align: 'center'
                    },
                    datalabels: {
                        backgroundColor: function (context) {
                            return context.datasetIndex == 0 ? context.dataset.backgroundColor : '';
                        },
                        borderRadius: 4,
                        color: 'white',

                        formatter: function (value, context) {
                            return context.datasetIndex == 0 ? Number(value).toLocaleString('en-GB', { style: 'percent', maximumFractionDigits: 2 }) : ''
                        },
                        padding: 6
                    }
                }
            },
            responsive: true,

        }
    );
});