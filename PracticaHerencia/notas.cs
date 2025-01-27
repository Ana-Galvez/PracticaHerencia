/*
 CONSTRUCTORES: de los hijos llaman al contructor padre por medio de :base()  "lo hace implícitamente c#"
PERO  si creamos un constructor este reemplaza al constructor por defecto y debemos usar :base() en constructor hijo
public Caballo (parametro para igualar parametro constructor padre):base(parametro constructor padre){}
PRINCIPIO DE SUSTITUCIÓN: "....SIEMPRE ES UN.." ej  humano es siempre un mamífero"  entonces humano hereda de mamifero
MAMIFERO humano1 = new Humano("ana");   pero no va a tomar mètodos o propiedades de la calse humano, solo del padre
POLIMORFISMO: MUCHAS FORMAS
1- Cuando en la clase padre y en la clase hijo tienen el mismo nombre y parámetros de un método, en principio al llamar a
método desde la clase hijo, el método a ejecutar es el del hijo NO el del padre
NEW antes del mètodo hijo: solo saca la advertencia verde
VIRTUAL antes del método padre: dice a c sharp que el método padre se va a sobreescribir en método hijos
OVERRIDE antes del método hijo: dice a c sharp que el método hijo va a sobreescribir al método padre
 */