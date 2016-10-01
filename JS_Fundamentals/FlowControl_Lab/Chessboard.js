function chessboard(size) {
    let html = '<div class="chessboard">\n';
    for (let row = 0; row < size; row++) {
        html += '<div>\n';
        let color = (row % 2 == 0)? 'black':'white';

        for (let col = 0; col < size; col++) {
            html+= `    <span class="${color}"></span>\n`;
            color = (color == 'white')?'black':'white';
        }
        html += '</div>\n';
    }
    return html + '</div>';
}

let css = document.createElement("style");
css.innerHTML = `
  body { background: #CCC; }
  .chessboard { display: inline-block; }
  .black, .white { 
     width:60px; height:60px;
     display: inline-block; }
  .black { background: black; }
  .white { background: white; }
`;
document.getElementsByTagName("head")[0].appendChild(css);
document.body.innerHTML = chessboard(["8"]);
