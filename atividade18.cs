 {
 static void Main (string[] args)
 {
int comprimento1, comprimento2, comprimento3;

console.WriteLine("digite o lado do triangulo:");
comprimento1 = int.Parse(console.RideLine());


console.WriteLine("digite o outro  lado do triangulo:");
comprimento2 = int.Parse(console.RideLine());



console.WriteLine("digite mais um lado:");
comprimento3 = int.Parse(console.RideLine());

if(comprimento1 == comprimento2 && comprimento3){
    console.WriteLine("ele e equilatero");

}else if(comprimento1 == comprimento2 && comprimento1 != comprimento3){
    console.WriteLine("ele é isosceles");
}else{
    console.WriteLine("ele e escaleno");
}

console.WriteLine("aperte enter para sair ..")
console.RideLine()
 }


    }