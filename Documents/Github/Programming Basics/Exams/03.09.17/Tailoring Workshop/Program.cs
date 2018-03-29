 if (incomeLeva > minSalary)
            {
                if (average < 5.5)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else if (incomeLeva < minSalary)
            {
                socialScholarship = minSalary * 0.35;
                if (average >= 5.5)
                {
                    scholarship2 = average * 25;
                    Console.WriteLine($"You get a scholarship for excellent results {scholarship2} BGN");
                }
                if (socialScholarship > scholarship2)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
                else if (scholarship2 > socialScholarship)
                {
                    Console.WriteLine($"You get a Social scholarship {scholarship2} BGN");
                }
            }