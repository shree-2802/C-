abstract class AllDataTypes{
    protected char charVal; //2bytes
    protected string stringVal; 

    //signed
    protected sbyte sbyteVal;//1byte
    protected short shortVal; //2bytes
    protected int intVal; //4bytes
    protected long longVal; //8bytes

    //unsigned (No negative values allowed)
    protected byte byteVal;
    protected ushort ushortVal;
    protected uint uintVal;
    protected ulong ulongVal;

    //decimals
    protected float floatVal; //4bytes
    protected double doubleVal; //8bytes
    protected decimal decimalVal; //16bytes

public AllDataTypes(int num){
    Console.WriteLine($"AllDataTypes initialised with the number {num} as prop.");
}
    public abstract void setAllValues();
    public abstract int getAllValues();
}

class DataSetAndGet:AllDataTypes{
    public DataSetAndGet(int num) : base(num){
        Console.WriteLine("DataSetAndGet initialised");
    }

    public override void setAllValues(){
        this.charVal='S';
        this.stringVal="Shivan Parvathi";
        this.sbyteVal=-127; //-128 to 127
        this.shortVal=32767; //-32768 to 32767
        this.intVal=Convert.ToInt32(Math.Pow(2,29)); //-2^31 to 2^31 - 1
        this.longVal=Convert.ToInt64(Math.Pow(-2,61)); //-2^63 to 2^63 -1
        this.byteVal=255; //0-255
        this.ushortVal=65535 ;//0-65535
        this.uintVal=Convert.ToUInt32(Math.Pow(2,31));//0-2^32
        this.ulongVal=Convert.ToUInt64(Math.Pow(2,61));
    }
    public override int getAllValues()
    {
        return this.intVal;
    }
}

DataSetAndGet dataSetAndGet=new DataSetAndGet(5);
dataSetAndGet.setAllValues();
Console.WriteLine(dataSetAndGet.getAllValues());