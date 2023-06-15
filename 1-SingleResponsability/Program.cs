using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();

var students = studentRepository.GetAll();

exportHelper.ExportEstudents(students);

Console.WriteLine("Proceso Completado");