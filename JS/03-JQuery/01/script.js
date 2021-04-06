const Lowercase = 'abcdefghijklmnopqrstuvwxyz';
const Uppercase = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
const Numeric = '0123456789';

function Generate(dictionary, length){
  let result = ''

  for(let i = 0; i < length; i++) {
    result += dictionary[Math.floor(Math.random() * dictionary.length)]
  }
  
  return result;
}

$(document).ready(() => {
  $('#form').submit((event) => {
    event.preventDefault();

    const length = $('#length').val();

    if(!$.isNumeric(length))
      return alert('String length should be a number');

    let dictionary = '';

    if($('#lowercase').is(':checked'))
      dictionary += Lowercase;
    if($('#uppercase').is(':checked'))
      dictionary += Uppercase;
    if($('#numeric').is(':checked'))
      dictionary += Numeric;

    if(dictionary.length <= 0)
      return alert('Choose at least one option');

    $('#result').val(Generate(dictionary, length));
  })
})