function submitForm() {
    var email = document.getElementById('email').value;
    var name = document.getElementById('name').value;
    var purpose = document.getElementById('purpose').value;
    var remark = document.getElementById('remark').value;

    if (email.trim() == "") {
      document.getElementById('err-email').style.visibility = 'visible';
    }
    else{
      document.getElementById('err-email').style.visibility = 'hidden';
    }
    if (name.trim()== '') {
      document.getElementById('err-name').style.visibility = 'visible';
    }
    else{
      document.getElementById('err-name').style.visibility = 'hidden';
    }
    if (purpose.trim() =='') {
      document.getElementById('err-purpose').style.visibility = 'visible';
    }
    else{
      document.getElementById('err-purpose').style.visibility = 'hidden';
    }
    if (remark.trim() == '') {
      document.getElementById('err-remark').style.visibility = 'visible';
    }
    else{
      document.getElementById('err-remark').style.visibility = 'hidden';
    }
  
    if (email.trim() !== '' && name.trim() !== '' && purpose.trim() !== '' && remark.trim() !== '') {
      alert("Your Copy of response is also sent to your given email id " + email);
    }
  }