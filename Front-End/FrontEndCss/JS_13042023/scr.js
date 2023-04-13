// Tabloyu seçin
// let multiplicationTable = document.getElementsByClassName("test")[0];

// for (let i = 1; i <= 10; i++) 
// {
//   let row = document.createElement("tr");
  
//   for (let j = 1; j <= 10; j++) 
//   {
//     let cell = document.createElement("td");
    
//     let cellValue = i * j;
//     cell.textContent = cellValue;    
//     row.appendChild(cell);
//   }  
//   multiplicationTable.appendChild(row);
// }




// document.getElementById("btn").addEventListener("click", displayDate);
// {
   
// }

// function displayDate() {
//     var text = document.getElementById("selam").value;
//     alert("Merhaba " + text);
//   }
       


    // function Hesapla() {
    //     let sonuc1 = Number(document.getElementById("txt1").value);
    //     let sonuc2 = Number(document.getElementById("txt2").value);
    //     alert("Hipotenus = " + Math.sqrt(Math.pow(sonuc1,2)+Math.pow(sonuc2,2)));
    //   }
    
      
    function Hesapla() {      

        document.getElementById("lbl").innerHTML = new Date().toLocaleTimeString();
      }