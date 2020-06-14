document.addEventListener("DOMContentLoaded",function(){
  var mytable = document.getElementById("mytable");
  var myform= document.forms;
  
//delete row
mytable.addEventListener("click",(e)=>{
     if( e.target.className=="delete")
     {
         var temp_value=e.target.parentElement;
         var del= temp_value.parentElement;
         del.parentNode.removeChild(del);         
     }
  })

// --------------------------------------------

//Edit row 
mytable.addEventListener("click",(e)=>{
     
  if( e.target.className=="edit")
  {
      e.preventDefault();
      var temp=e.target.parentElement;
      var editrow= temp.parentElement;
      var cel1=editrow.cells[0];
      var cel2=editrow.cells[1];
      var cel3=editrow.cells[2];
      cel1.innerHTML="<input type='text' name='name'>";
      cel2.innerHTML="<input type='text' name='Country'>";
      cel3.innerHTML="<input type='text' name='Age'>";

      
     console.log(editrow)
    }

    //save
     mytable.addEventListener("click",(e)=>{
        
          if(e.target.className=="save"){
              e.preventDefault();

              var s_name=addrow.querySelector("input[name='name']").value;
              var s_country=addrow.querySelector("input[name='Country']").value;
              var s_age=addrow.querySelector("input[name='Age']").value;

              cel1.textContent=s_name;
              cel2.textContent=s_country;
              cel3.textContent=s_age;
                   
          }
         
      })

})

// -----------------------------------------------------------------
  // add row
  var addrow= myform["myform"];
  addrow.addEventListener("submit",(e)=>{
      e.preventDefault();
     
      var name= addrow.querySelector("input[name='name']").value;
      var country= addrow.querySelector("input[name='Country']").value;
      var age= addrow.querySelector("input[name='Age']").value;

      
      var trow= document.createElement("tr");
      var pname=document.createElement("td");
      var pcountry=document.createElement("td");
      var page=document.createElement("td");
      var addrowbtn=document.createElement("td");
      var rowedit=document.createElement("button");
      var rowsave=document.createElement("button");
      var rowdelete=document.createElement("button");

      
      pname.textContent=name;
      pcountry.textContent=country;
      page.textContent=age;
      rowedit.textContent="Edit";
      rowsave.textContent="Save";
      rowdelete.textContent="Delete";
      
    addrowbtn.className="esd";
      rowedit.className="edit";
      rowsave.className="save";
      rowdelete.className="delete";
    
      trow.appendChild(pname);
      trow.appendChild(pcountry);
      trow.appendChild(page);
      trow.appendChild(addrowbtn);
      addrowbtn.appendChild(rowedit);
      addrowbtn.appendChild(rowsave);
      addrowbtn.appendChild(rowdelete);

      var referenceElement = document.querySelector('#add_row');
      referenceElement.before(mytable.appendChild(trow));

     addrow.querySelector("input[name='name']").value = "";
     addrow.querySelector("input[name='Country']").value = "";
     addrow.querySelector("input[name='Age']").value = "";

  })

// --------------------------------------------------

})