// Variável global para guardar a instância do gráfico
var meuGraficoPizza = null;

function desenharGraficoPizza(labels, data) {
    // Pega o "quadro" (canvas) onde vamos desenhar
    var ctx = document.getElementById('graficoPizza').getContext('2d');

    // Se o gráfico já existir, destrói ele antes de desenhar um novo
    // Isso é MUITO importante para as atualizações!
    if (meuGraficoPizza != null) {
        meuGraficoPizza.destroy();
    }

    // Cria o novo gráfico
    meuGraficoPizza = new Chart(ctx, {
        type: 'pie', // Tipo de gráfico (pizza)
        data: {
            labels: labels, // Ex: ["Alimentação", "Transporte"]
            datasets: [{
                label: 'Gastos por Categoria',
                data: data, // Ex: [500, 200]
                backgroundColor: [ // Cores (pode adicionar mais)
                    'rgba(255, 99, 132, 0.7)',
                    'rgba(54, 162, 235, 0.7)',
                    'rgba(255, 206, 86, 0.7)',
                    'rgba(75, 192, 192, 0.7)',
                    'rgba(153, 102, 255, 0.7)',
                    'rgba(255, 159, 64, 0.7)'
                ]
            }]
        }
    });
}