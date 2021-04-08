class Component {
  constructor(tag, childs, params = undefined) {
    this.tag = tag;
    this.childs = childs;
    this.params = params;
  }

  render() {
    let el = document.createElement(this.tag);
    
    if (this.params) {
      Object.keys(this.params).forEach((param) => {
        el[param] = this.params[param];
      })
    }

    this.childs.forEach(child => {
      if (child.render) {
        el.appendChild(child.render());
      } else {
        el.appendChild(document.createTextNode(child));
      }
    });
    
    return el;
  }
}