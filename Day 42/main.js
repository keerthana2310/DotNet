
// var val1="Hey";
// var val2="Boss";
// console.log(val1+" "+val2);
// var name='Jack';
// var age=23;
// var dob="10-09-22";
// // var message="Hi,my name is "+ name +" I am  "+age +"years old";
// // console.log(message);
// var sum=15+10;
// console.log(sum);
// var mod=10%3;
// console.log(mod);
// var result=10*((5+3)-4);
// console.log(result);
// if(1==1)
// console.log("we should see this 1");
// var age1=20;
// var age2=20;
// if(age1==age2){
//     console.log("They are same")
// }else{
//     console.log("They are different")
//}

// document.write("Learn javascript");
// alert("hello");
// console.log("world");
// console.log(1+3);
// document.write("<h1>learn</h1>");

// var person="John";
// let person1="smith";
// document.write(person);
// document.write("<br>");
// document.write(typeof person1);
// document.write("<br>");
// //number
// var num1=90;
// var num2=7;
// document.write(num1);
// document.write("<br>");
// document.write(typeof num1+"<br>");
// //boolean
// var js=true;
// var html=false;
// //undefined
// var test1;
// document.write(test1);
// document.write("<br>");
// document.write(typeof test1+"<br>");
// //null
// var tes2=null;
// document.write(tes2);
// document.write("<br>");
// document.write(typeof tes2+"<br>");
// var a=10,b=20;
// document.write(a+b+"<br>");
// var a=10;
// document.write(a**2+"<br>");
// var x=10;
// var result=x-=4;
// document.write(result+"<br>");
// var a=80;
// var b=80;
// document.write(a==b+"<br>");
// var a="20";
// var b="20";
// document.write(a===b+"<br>");     //check value and type
// var a="A";
// switch(a){
//     case "A":
//         document.write("Apple");
//         break;
//         case "B":
//             document.write("Mango");
//             break;
//             case "C":
//                 document.write("Orange");
//                 break;
//                 default:
//                     document.write("Invalid Character");
//                     break;
// }
// document.write("<br>");
// var i=1;
// while(i<=5){
// document.write(i+"<br>");
// i++;
// }
// function greetings(name){
//     document.write("Good Morning "+name+"<br>");
// }
// greetings("john");
// greetings("ran");
// function sum(n1,n2){
//     document.write(n1+n2);
// }
// sum(10,20);
// function sum(n1,n2){
//     return n1+n2;
// }
// var result=sum(10,20);
// document.write(result);
 
// var animal=["Lion","Tiger","Cat"];
// //animal[5]="Elephant";
// animal.sort();
// //animal.splice(2,3);
// document.write(animal);

// var num=[20,30,15,60];
// //num.sort();
// document.write(num[0]+num[3]);

// var text="Java Script";
// //document.write(text[5]);
// document.write(text.charAt(7));

// var text1="paru";
// var text2="kannan";
// document.write(text1.concat(text2));

// var a=document.getElementById("head1");
// //console.log(a);
// //a.innerHTML="Learn Javascript";
// a.style.color="green";

// var a=document.getElementsByClassName("head1");
// a[1].innerHTML="Good Morning";            //according to the index it changes in html p and h tags.
// console.log(a);
var a=document.getElementsByTagName("h1");
console.log(a);
a[0].innerHTML="changed paragraph";
a[1].style.color="purple";