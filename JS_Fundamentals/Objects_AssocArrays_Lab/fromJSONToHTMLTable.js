function JSONToHTMLTable([json]) {
    let html = "<table>\n";
    let arr = JSON.parse(json);
    html += "  <tr>";
    for (let key of Object.keys(arr[0]))
        html += `<th>${htmlEscape(key)}</th>`;
    html += "</tr>\n";

    for (let obj of arr) {
        html += '  <tr>';
        for (let value of Object.keys(obj)) {
            html += `<td>${htmlEscape(obj[value])}</td>`;
        }
        html += "</tr>\n";

        html += "</table>";
        return html;
    }
    return html;
    function htmlEscape(text) {
        text = new String(text);
        let map = {
            '"': '&quot;', '&': '&amp;',
            "'": '&#39;', '<': '&lt;', '>': '&gt;'
        };
        return text.replace(/[\"&'<>]/g, ch => map[ch]);
    }
}
console.log(
    JSONToHTMLTable(['[{"X":5,"Y":7},{"X":2,"Y":4}]']));