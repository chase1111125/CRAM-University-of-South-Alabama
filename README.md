# CRAM Final Submission for the University of South Alabama Team

Hardware Findings
The hardware demo and findings are listed below. We first began our hardware approach knowing we wanted to better understand how the listed CVEs on the System Under Evaluation documentation impacted each node and area of the business. To do this we had to first store the data. Our team juggled the idea of creating a database for storing the CVEs but due to time constraints and pivoting our idea around week 2, We ended up going with a more simplistic approach to produce a working demo. We used two CSV files that are read in on both the direct full “ConsoleResillienceCalculator” and the “ResillienceCalculator”. We ended up reading all the company’s component data and the likelihood of using an Exploit Prediction Scoring System (EPSS). EPSS is defined here: “EPSS is a daily estimate of the probability of exploitation activity being observed over the next 30 days” [5]. Our team decided this approach would be best to represent the likelihood of the risk for the company because the EPSS system represents likelihood and risk more accurately. The EPSS model predicts likelihood better than the CVSS system as it is trained on machine learning of previous CVEs and is constantly updated. Returning to the CSV files being pulled into our program, the first CSV file being read in is the “MasterNodeList”, this CSV corresponds to the individual nodes and associated data and CVE data listed in the documentation. This second file “EPSS_Scores-2024-10-07” contains all CVEs from the first CVE to the date of the EPSS download. Inside the EPSS scores CSV, only the first 2 columns are being used for our demo. The third is a percentile of all CVEs against the whole database which we did not use in our program. 
Once the data is pulled into the program the program manipulates this data throughout different sections on the hardware page of the GUI. The GUI first calculates the risk which pulls all the known data on a certain node including associated CVEs, Software makes, and versions. Software versions present a warning when software is outdated. One finding we found for MRZTech is that ALL hardware components are outdated or at End-Of-Life (EOL). For demonstration purposes, we only included RHEL, Windows Server 2008, and CISCO IOS versions. Once we were able to successfully manipulate the data within the GUI, we found it was very easy to flag simple things such as software version and could be expanded further in the future. 
Underneath the “Node Info” section, the GUI lists all CVEs for that particular node as well as the matching CVE score from the EPSS_Scores CSV file. This then averages the score in the box for the total node likelihood. 
To the right under the “CVE Risk & Inspector” header, the user will have the option to select the specific CVE under the current node. This allows the user to better understand the risk and impact this vulnerability would have on the company and its respective functions. In addition to listing the functions of the business that are impacted, The CVE is shown with the NVD score, and underneath the CVE risk is calculated. The risk is calculated by normalizing the two weighted averages of the CVE EPSS score and the CVE Function Severity. The reason we choose to use a weighted score for both of the calculations is that we do not want to misrepresent one score from another. If we had one score of 3 and two scores of 1, we do not want the two 1s to drag the severity average of the 3 down. This would misrepresent the risk and not help the company. After calculating the weighted averages, we apply a normalization formula to scale the severity average to a range of 0 to 3. This normalized value is then added to the EPSS score, ensuring the combined result stays within the 0 to 3 range that we are looking for in our final formula.  The data on the hardware page will update as a new node is inputted and the calculate resilience button is clicked. 
Backing out to the menu again, you can open the physical resilience GUI which will help the user calculate the physical resilience of the company based on the physical resilience checklist. This is averaged and weighted and produces a number between 0-1. Backing out to the menu again, you can open the software resilience GUI which will help the user calculate the software resilience based on the Entropy detected from the software python imaging script and the amount of files run. The result of this calculation is an average between 0-1.
On the main menu, the user can click on “Final Scoring.” This scoring GUI allows the user to input the data in and using the formula below calculate the resilience of the system. 



Software Findings
As for software, we were able to successfully visualize .exe, .pdf, and .txt files into colorized RPG tables that are saved as .png files. This is useful for creating a good image representation of data for machine learning models. This transforms each byte or character from the text or binary files respectively into visual features that these models can use. An example of one .exe malware file is found below.

Colorized Image of a Sample of 7ev3n.exe Ransomware
As previously mentioned, we had success visualizing .exe, .pdf, and .txt file types for benign and malware file types, but fell short of being able to run .doc and .docx files through it. This is likely due to the additional objects and macros that the script extracts from these files before executing it. It can, however, visualize each extracted piece from these files, including the content. This could be useful for this use case, but we ultimately decided to not include it due to time constraints. 
We tried many different methods to utilize these visualizations in creating a software resilience score, but due to our lack of knowledge in developing AI and machine learning models, we decided to calculate entropy instead. Entropy, since it is being used on an image, refers to a measure of randomness of pixel values found in the image. It can be useful for identifying whether or not an image has several regular or random patterns. This could be useful for detecting the presence of malicious code found inside a file but is ultimately only useful as a form of anomaly detection. It would be better used in conjunction with something else, as false positives are common. For the time being, we have it working for calculating the entropy of the entire image, but would be better if segments of the image could be calculated instead, but could not be implemented due to time constraints. This would be better done this way, as it would more easily show where malicious code could be found from within a colorized image of a file. The entropy is currently used in the software calculation as the total number of files divided by the average entropy of all files.
Using the Final_Data_Script.py that we have created, we have created a data set of ten files containing both benign and malicious files. The malware that was run through this script was sourced from a GitHub repository called “The-MALWARE-Repo” created by Da2Dalus. [4] The five malicious files consist of samples from ransomware, spyware, a trojan, a remote access trojan, and an email worm. These are all .exe files. The colorized files are named appropriately based on the sample it was taken from and the type of malware that it is. The benign files consist of .exe, .pdf, and .txt files.
The way that text and binary files are outputted from the program differ as well. This is because the ASCII characters from the text files are mapped according to RGB values, while bytes from the binary files are mapped according to RGB values instead. The text files are outputted as diagonal lines, while the binary files are outputted as horizontal lines.
