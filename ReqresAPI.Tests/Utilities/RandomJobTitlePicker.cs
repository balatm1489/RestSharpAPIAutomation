﻿namespace ReqresAPI.Tests.Utilities
{

    public class RandomJobTitlePicker
    {
        string getJobTitle = "";
        // A array of authors
        string[] jobTitle = { "Marketing Specialist","Marketing Manager","Marketing Director","Graphic Designer","Marketing Research Analyst","Marketing Communications Manager","Marketing Consultant","Product Manager","Public Relations","Social Media Assistant","Brand Manager",
            "SEO Manager","Content Marketing Manager","Copywriter","Media Buyer","Digital Marketing Manager",
            "eCommerce Marketing Specialist","Brand Strategist","Vice President of Marketing","Media Relations Coordinator","Administrative Assistant","Receptionist","Office Manager","Auditing Clerk",
            "Bookkeeper","Account Executive","Branch Manager","Business Manager","Quality Control Coordinator","Administrative Manager","Chief Executive Officer","Business Analyst","Risk Manager","Human Resources","Office Assistant","Secretary","Office Clerk","File Clerk",
            "Account Collector","Administrative Specialist",
            "Executive Assistant","Program Administrator",
            "Program Manager","Administrative Analyst","Data Entry","Team Leader","Manager","Assistant Manager","Executive","Director","Coordinator","Administrator","Controller","Officer","Organizer","Supervisor","Superintendent","Head","Overseer","Chief",
            "Foreman","Controller","Principal","President","Lead","Computer Scientist","IT Professional","UX Designer & UI Developer","SQL Developer",
            "Web Designer","Web Developer","Help Desk Worker/Desktop Support","Software Engineer","Data Entry","DevOps Engineer","Computer Programmer","Network Administrator","Information Security Analyst","Artificial Intelligence Engineer","Cloud Architect","IT Manager",
            "Technical Specialist","Application Developer","Chief Technology Officer (CTO)","Chief Information Officer (CIO)","Sales Associate","Sales Representative","Sales Manager","Retail Worker","Store Manager","Sales Representative","Sales Manager","Real Estate Broker",
            "Sales Associate","Cashier","Store Manager","Account Executive","Account Manager","Area Sales Manager","Direct Salesperson","Director of Inside Sales","Outside Sales Manager","Sales Analyst","Market Development Manager","B2B Sales Specialist","Sales Engineer",
            "Merchandising Associate","Construction Worker","Taper","Plumber","Heavy Equipment Operator","Vehicle or Equipment Cleaner","Carpenter","Electrician",
            "Painter","Welder","Handyman","Boilermaker","Crane Operator","Building Inspector","Pipefitter","Sheet Metal Worker","Iron Worker","Mason","Roofer","Solar Photovoltaic Installer",
            "Well Driller","CEO","Proprietor","Principal","Owner","President","Founder","Administrator","Director","Managing Partner","Managing Member","Board of Directors","C-Level or C-Suite.",
            "Shareholders","Managers","Supervisors","Front-Line Employees","Quality Control","Human Resources","Accounting Staff","Marketing Staff","Purchasing Staff","Shipping and Receiving Staff","Office Manager","Receptionist","Virtual Assistant","Customer Service","Customer Support",
            "Concierge","Help Desk","Customer Service Manager","Technical Support Specialist",
            "Account Representative","Client Service Specialist","Customer Care Associate","Operations Manager","Operations Assistant","Operations Coordinator","Operations Analyst","Operations Director","Vice President of Operations","Operations Professional","Scrum Master",
            "Continuous Improvement Lead","Continuous Improvement Consultant","Credit Authorizer","Benefits Manager","Credit Counselor","Accountant","Bookkeeper","Accounting Analyst","Accounting Director","Accounts Payable/Receivable Clerk","Auditor","Budget Analyst",
            "Controller","Financial Analyst","Finance Manager","Economist","Payroll Manager","Payroll Clerk","Financial Planner","Financial Services Representative","Finance Director",
            "Commercial Loan Officer","Engineer","Mechanical Engineer","Civil Engineer","Electrical Engineer","Assistant Engineer","Chemical Engineer","Chief Engineer","Drafter","Engineering Technician","Geological Engineer","Biological Engineer","Maintenance Engineer","Mining Engineer",
            "Nuclear Engineer","Petroleum Engineer","Plant Engineer","Production Engineer","Quality Engineer","Safety Engineer","Sales Engineer","Researcher","Research Assistant","Data Analyst","Business Analyst","Financial Analyst","Biostatistician","Title Researcher","Market Researcher",
            "Title Analyst","Medical Researcher","Mentor","Tutor/Online Tutor","Teacher","Teaching Assistant","Substitute Teacher","Preschool Teacher","Test Scorer","Online ESL Instructor","Professor","Assistant Professor" };


        public string getJobTitlePicker()
        {
            try
            {
                // Create a Random object
                Random rand = new Random();
                int index = rand.Next(jobTitle.Length);
                getJobTitle = jobTitle[index];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return getJobTitle;
        }
    }
}
