jQuery(document).ready(function(){
    jQuery('#password').keypress(function (e) {
     var key = e.which;
         if(key == 13)  // the enter key code
         {
            jQuery('input[name = submit_btn]').click();
            return false;  
        }
    });   
    jQuery("#submit_btn").click(function(){
        var username = $("#username").val();
        var pass = $("#password").val();

        if(username == ''){
            alert('please enter username');
            return false;
        }else if(pass == ''){
            alert('please enter password');
            return false;
        }else if(username == 'admin' && pass == '12345'){
            //alert('You are successful login');
            
            //localStorage.setItem("username", "admin");
            //localStorage.setItem("password", "12345");
            var delay = 2000; 
            var url = 'home.html'
            setTimeout(function(){ window.location = url; }, delay);                 
        }else {
            alert('Please enter the correct credentials');
            return false;
        }     
    });
});