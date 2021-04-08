class DOM {
  static render(element, parent) {
    parent.appendChild(element.render());
  }
}