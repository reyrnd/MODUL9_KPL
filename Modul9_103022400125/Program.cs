using Modul9_103022400125;

class Program
{
    public static void Main(string[] args) { 
        BankTransferConfig bankConfig = new BankTransferConfig();

        Double transfer;
        Double fee;
        int method;

        if (bankConfig.config.lang == "en")
        {
            Console.Write("“Please insert the amount of money to transfer: ");
            transfer = int.Parse(Console.ReadLine());

            if (transfer <= bankConfig.config.transfer.threshold) {
                fee = bankConfig.config.transfer.low_fee;
                Console.WriteLine($"Transfer Fee = {fee}");
            } else
            {
                fee = bankConfig.config.transfer.high_fee;
                Console.WriteLine($"Transfer Fee = {fee}");
            }

            Console.WriteLine($"Total Amount = {transfer + fee}");

            Console.WriteLine($"Select transfer method: ");
            bankConfig.config.methods.ForEach(method => Console.WriteLine(method));

            Console.WriteLine($"Please type {bankConfig.config.confirmation.en} to confirm the transaction:");
            method = int.Parse(Console.ReadLine());

            Console.Write("The transfer is completed using ");

            if (method == 1)
            {
                Console.WriteLine("RTO (real-time)");
            }
            else if (method == 2)
            {
                Console.WriteLine("SKN");
            }
            else if (method == 3)
            {
                Console.WriteLine("RTGS");
            }
            else if (method == 4) {
                Console.WriteLine("BI FAST");
            }

        }
        else {
            Console.WriteLine("Masukkan jumlah uang yang akan di transfer: ");
            transfer = int.Parse(Console.ReadLine());

            if (transfer <= bankConfig.config.transfer.threshold)
            {
                fee = bankConfig.config.transfer.low_fee;
                Console.WriteLine($"Biaya Transfer = {fee}");
            }
            else
            {
                fee = bankConfig.config.transfer.high_fee;
                Console.WriteLine($"Biaya Transfer = {fee}");
            }

            Console.WriteLine($"Total Biaya = {transfer + fee}");

            Console.WriteLine($"Pilih metode transfer: ");
            bankConfig.config.methods.ForEach(method => Console.WriteLine(method));

            Console.WriteLine($"Please type {bankConfig.config.confirmation.en} to confirm the transaction:");
            method = int.Parse(Console.ReadLine());

            Console.Write("The transfer is completed using ");

            if (method == 1)
            {
                Console.WriteLine("RTO (real-time)");
            }
            else if (method == 2)
            {
                Console.WriteLine("SKN");
            }
            else if (method == 3)
            {
                Console.WriteLine("RTGS");
            }
            else if (method == 4)
            {
                Console.WriteLine("BI FAST");
            }
        }
    }
}