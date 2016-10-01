function multiplicationTable([n]) {
    n = Number(n);
    let html = '';
    html+="<table border='2'>";
    for (let i = 0; i <= n; i++) {

        html+= "<tr>";

        for (let j = 0; j <= n; j++) {
            if (i == 0 && j == 0) {
                html+='<th>x</th>';
            }
            else if (i == 0)  html+=`<th>${j}</th>`;
            else if (j == 0) html+=`<th>${i}</th>`;
            else {
                html+=`<td>${i * j}</td>`
            }
        }
        html+= "</tr>\n";
    }
    return html +"</table>";
}
document.body.innerHTML = multiplicationTable(['10']);
//console.log(multiplicationTable(['5']));