namespace Models
{
    public class Car
    {
        public readonly string INSERT = "INSERT INTO TB_Car (Name, Color, Year) VALUES (@Name, @Color, @Year)\" ;
        public readonly string UPDATE = "UPDATE TB_Car SET Name = @Name, Color = @Color, Year = @Year WHERE Id = @Id";
        public readonly string GET = 
        public readonly string GETALL = "SELECT Id, Name, Color, Year FROM TB_Car WHERE Id = @Id";
        public readonly string DELETE = "DELETE FROM TB_Car WHERE Id = @Id";

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Name}, Cor: {Color}, Ano: {Year}";
        }
    }
}
