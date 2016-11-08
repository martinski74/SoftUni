class TitleBar {
    constructor(title) {
        this.title = title;
        this.menu = [];
    }

    addLink(href, name) {
        this.menu.push($(`<a class="menu-link" href="${href}">${name}</a>`));
    }
    appendTo(selector){
        $(selector).append(this.generate());

        let button = $('header').find('.button');
        button.click(this.togle.bind(this));
    }
    generate(){
        let html = $(`<header class="header">
  <div class="header-row">
    <a class="button">&#9776;</a>
    <span class="title">${this.title}</span>
  </div>
  <div class="drawer">
    <nav class="menu">
    </nav>
  </div>
</header>`);
        let menu = html.find('.menu');
        for(let item of this.menu){
            menu.append(item);
        }

        return html;
    }
    togle(){
        let menu = $('header').find('.menu');
        if(menu.css('display') == 'none'){
            menu.css('display','block');
        }else {
            menu.css('display','none');
        }
    }
}
