const SIZE = 16;
const FREQ = 2;

let grid = document.getElementById('grid');

function at(x, y) {
    return document.querySelector(`#row-${x} #col-${y}`);
}

function visit(x, y) {
    at(x, y).classList.add('visited');
}

for (let i = 0; i < SIZE; i++) {
    let row = document.createElement('div');
    row.id = 'row-' + i;
    row.classList.add('row');

    for (let j = 0; j < SIZE; j++) {
        let col = document.createElement('div');
        col.id = 'col-' + j;
        col.classList.add('col');

        if (Math.floor(Math.random() * FREQ) % FREQ == 0) {
            col.classList.add('visited');
        }

        col.addEventListener('click', () => {
            visit(i, j);
        });

        row.appendChild(col);
    }
    grid.appendChild(row);
}
