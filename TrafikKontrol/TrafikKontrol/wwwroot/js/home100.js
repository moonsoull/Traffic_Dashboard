var testData = [];
var testData1 = [];
var testData2 = [];
var testData3 = [];
var testData4 = [];
var testData5 = [];
var testData6 = [];
var testData7 = [];
var testData8 = [];
var testData9 = [];
var testData10 = [];
var testData11 = [];
var testData12 = [];
var testData13 = [];

function chart() {
	var k = 0;
	$.ajax({
		type: "GET",
		url: "/Home/Get_Sensortype100",
		success: function (response) {
			response.forEach(obj => {

				testData.push(parseInt(obj['sensorid']));
				testData2.push(parseInt(obj['toplam']));
				k++;
			});


		
			var ctx = document.getElementById('pie-chart100').getContext('2d');
			var chart = new Chart(ctx, {
				// The type of chart we want to create
				type: 'pie', // also try bar or other graph types

				// The data for our dataset
				data: {
					labels: testData,
					// Information about the dataset
					datasets: [{
						label: "Toplam Araç",
						backgroundColor: ["#3e95cd", "#8e5ea2", "#3cba9f", "#e8c3b9", "#c45850", "#997a8d", "#ace5ee", "#734a12", "#943391", "#b0b7c6", "#0bda51", "#ea7e5d", "#82898f", "#8b8940", "#ffd700"],
						data: testData2,
					}]
				},

				// Configuration options
				options: {
					layout: {
						padding: 10,
					},
					legend: {
						position: 'bottom',
					},
					title: {
						display: true,
						text:  'Araç Yönü Toplam Sayısı Grafiği'
					},
				}
			});
		},

	});

}


function chart2() {
	var m = 0;

	$.ajax({
		type: "GET",
		url: "/Home/Get_Yon100",
		success: function (response) {
			response.forEach(obj => {

				testData1.push(obj['sensortipi']);
				testData3.push(parseInt(obj['Toplam']));
				m++;
			});



			var ctx = document.getElementById('doughnut-chart100').getContext('2d');
			var chart = new Chart(ctx, {
				// The type of chart we want to create
				type: 'doughnut', // also try bar or other graph types

				// The data for our dataset
				data: {
					labels: testData1,
					// Information about the dataset
					datasets: [{
						label: "YÖN",
						backgroundColor: ["#3e95cd", "#8e5ea2", "#3cba9f", "#e8c3b9", "#c45850", "#997a8d", "#ace5ee", "#734a12", "#943391", "#b0b7c6", "#0bda51", "#ea7e5d", "#82898f", "#8b8940", "#ffd700", "#bebd7f", "#c41e3a", "#006400", "#53377a", "#d76e00", "#ffcbbb", "#7fffd4", "#008080", "#1e90ff", "#00a86b", "#b87333", "#b55489", "#0bda51"],
						data: testData3,
					}]
				},

				// Configuration options
				options: {
					layout: {
						padding: 10,
					},
					legend: {
						position: 'bottom',
					},
					title: {
						display: true,
						text: 'Araç Yön Tipi Grafiği'
					},
				}
			});
		}
	});
}


function chart3() {
	var n = 0;
	$.ajax({
		type: "GET",
		url: "/Home/Get_Top100",
		success: function (response) {
			response.forEach(obj => {

				testData4.push((obj['tarih']));
				testData5.push(parseInt(obj['Toplam']));
				n++;
			});
			function filterDate(day) {
				console.log(day.value);
			}


			var ctx = document.getElementById('line-chart100').getContext('2d');
			var chart = new Chart(ctx, {
				// The type of chart we want to create
				type: 'line', // also try bar or other graph types

				// The data for our dataset
				data: {
					labels: testData4,
					// Information about the dataset
					datasets: [{
						label: "Aracın En Çok Geçtiği Zamanlar ",
						backgroundColor: 'lightblue',
						borderColor: 'purple',
						data: testData5,
					}]
				},

				// Configuration options
				options: {
					layout: {
						padding: 10,
					},
					legend: {
						position: 'bottom',
					},
					title: {
						display: true,
						text: 'Araç Sayısı'
					},
					scales: {
						yAxes: [{
							scaleLabel: {
								display: true,
								labelString: 'Araç Sayısı'
							}
						}],
						xAxes: [{
							scaleLabel: {
							
								display: true,
								labelString: 'Sensor Tipi'
							}
						}]
					}
				}
			});
		},

	});
}


function chart4() {
	var p = 0;
	$.ajax({
		type: "GET",
		url: "/Home/Get_Tarih11_100",
		success: function (response) {
			response.forEach(obj => {

				testData6.push((obj['tarih']));
				testData7.push(parseInt(obj['Toplam']));
				p++;
			});
			function filterDate(day) {
				console.log(day.value);
			}


			var ctx = document.getElementById('bar-chart-horizontal100').getContext('2d');
			var chart = new Chart(ctx, {
				// The type of chart we want to create
				type: 'horizontalBar', // also try bar or other graph types

				// The data for our dataset
				data: {
					labels: testData6,
					// Information about the dataset
					datasets: [{
						label: "Araç Sayısı ",
						backgroundColor: ["#3e95cd", "#8e5ea2", "#3cba9f", "#e8c3b9", "#c45850"],
						data: testData7,
					}]
				},

				// Configuration options
				options: {
					legend: { display: false },
					title: {
						display: true,
						text: '2023-08-11 Aracın En Çok Geçtiği 5 Saat'
					}
				}
			});
		}
	});
}


function chart5() {
	var p = 0;
	$.ajax({
		type: "GET",
		url: "/Home/Get_Tarih12_100",
		success: function (response) {
			response.forEach(obj => {

				testData8.push((obj['tarih']));
				testData9.push(parseInt(obj['Toplam']));
				p++;
			});
			function filterDate(day) {
				console.log(day.value);
			}


			var ctx = document.getElementById('bar-chart-horizontal100_1').getContext('2d');
			var chart = new Chart(ctx, {
				// The type of chart we want to create
				type: 'horizontalBar', // also try bar or other graph types

				// The data for our dataset
				data: {
					labels: testData8,
					// Information about the dataset
					datasets: [{
						label: "Araç Sayısı ",
						backgroundColor: ["#3e95cd", "#8e5ea2", "#3cba9f", "#e8c3b9", "#c45850"],
						data: testData9,
					}]
				},

				// Configuration options
				options: {
					legend: { display: false },
					title: {
						display: true,
						text: '2023-08-12 Aracın En Çok Geçtiği 5 Saat'
					}
				}
			});
		}
	});
}


function chart6() {
	var p = 0;
	$.ajax({
		type: "GET",
		url: "/Home/Get_Tarih13_100",
		success: function (response) {
			response.forEach(obj => {

				testData10.push((obj['tarih']));
				testData11.push(parseInt(obj['Toplam']));
				p++;
			});
			function filterDate(day) {
				console.log(day.value);
			}


			var ctx = document.getElementById('bar-chart-horizontal100_2').getContext('2d');
			var chart = new Chart(ctx, {
				// The type of chart we want to create
				type: 'horizontalBar', // also try bar or other graph types

				// The data for our dataset
				data: {
					labels: testData10,
					// Information about the dataset
					datasets: [{
						label: "Araç Sayısı ",
						backgroundColor: ["#3e95cd", "#8e5ea2", "#3cba9f", "#e8c3b9", "#c45850"],
						data: testData11,
					}]
				},

				// Configuration options
				options: {
					legend: { display: false },
					title: {
						display: true,
						text: '2023-08-13 Aracın En Çok Geçtiği 5 Saat'
					}
				}
			});
		}
	});
}

function chart7() {
	var p = 0;
	$.ajax({
		type: "GET",
		url: "/Home/Get_Tarih14_100",
		success: function (response) {
			response.forEach(obj => {

				testData12.push((obj['tarih']));
				testData13.push(parseInt(obj['Toplam']));
				p++;
			});
			function filterDate(day) {
				console.log(day.value);
			}


			var ctx = document.getElementById('bar-chart-horizontal100_3').getContext('2d');
			var chart = new Chart(ctx, {
				// The type of chart we want to create
				type: 'horizontalBar', // also try bar or other graph types

				// The data for our dataset
				data: {
					labels: testData12,
					// Information about the dataset
					datasets: [{
						label: "Araç Sayısı ",
						backgroundColor: ["#3e95cd", "#8e5ea2", "#3cba9f", "#e8c3b9", "#c45850"],
						data: testData13,
					}]
				},

				// Configuration options
				options: {
					legend: { display: false },
					title: {
						display: true,
						text: '2023-08-14 Aracın En Çok Geçtiği 5 Saat'
					}
				}
			});
		}
	});
}

document.addEventListener('DOMContentLoaded', function () {
	chart();
	chart2();
	chart3();
	chart4();
	chart5();
	chart6();
	chart7();

}, false);