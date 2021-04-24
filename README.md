# Physician

As Kanye West said:

> We're living the future so
> the present is our past.

## Problem

Most millennial physicians are burnt out and have little or no work-life balance. 

Research shows that physicians work an average of 51.4 hours a week, with nearly 1 in 4 (23.5%) working 61–80 hours each week. After factoring in sleep, it is hard to justify the “time outside of medicine?” 

Female physicians, in particular, report work-life balance as a significant concern, with the goal of achieving this balance often affecting their career choices. Recent statistics show an increase in the numbers of female physicians in the United States with females representing 52% of medical students and 46% of residents in 2018–2019. However, research suggests that there has been little change for females in terms of domestic tasks and responsibilities.

## The Goal

The goal is to alleviate the time pressure that physicians are experiencing, this application helps all overwhelmed doctors, especially in this COVID-19 pandemic on how effectively they can analyze, diagnose and treat patient’s health conditions by refraining from engaging in time-consuming redundant activities.

## Introduction
When first starting out this project, there were two questions I wanted to solve.
1) Is it possible to use Artificial Intelligence(AI) to detect disease using an X Ray scan?
Multiple scientific studies, such as a publication called TX-CNN: DETECTING TUBERCULOSIS IN CHEST X-RAY IMAGES USING CONVOLUTIONAL NEURAL NETWORK by Chang Liu, Yu Cao, Marlon Alcantara, Benyuan Liu, Maria Brunette, Jesus Peinado, Walter Curioso, theorize that the best ways to diagnose tuberculosis (this is just the example I use, however in theory this same process can be used for virtually any disease) is through CNN’s or Convolutional Neural Network. 
2) How to best utilize physicians time by effectively reduce their valuable time spent on reviewing Electronic Health Records (EHD’s)  which technically consumes more than 50% of their workday as per the recent research conducted by American Medical Association. 
The questions all relate to the science aspect of the science fair. I wanted to be able to solve the problem physicians face by doing the X Ray scan in a shorter, much more effective time frame

## Framework
Experiencing symptoms but are you not sure what that means? Physicians can use the Symptom Checker feature in this application to help determine possible causes and treatments, and come up with a course of action based on the diagnosis. The plan in the future is to integrate with a SymptomChecker API and derive diagnosis conclusions.
While efficiency is the revolving idea, the most scientific element of this application is the Tuberculosis Image Diagnosis. There are definitely tuberculosis detecting software out there, however most of the time the x-ray is sent to a radiologist who interprets this data and returns it back to the doctor. With this application in place, amount of time involving the radiologists will be greatly decreased since an accurate detailed report for if the patients have contracted TB is generated. My goal for this sector of the project is to eventually expand to where it can detect any disease through an x-ray scan.
Speciality physicians spend on an average of 20 minutes on electronic health records (EHRs) for each patient visit. This application ‘voice automated notes’ feature greatly minimizes that time by translating doctor’s voice to text and is stored as notes that could be used in later time (alleviating the typing time). In the future there is a plan to analyze these notes using Natural Language Processing (aka. NLP). The goal of using NLP is to detect keywords and react accordingly which would include sending a prescription directly to the patient’s preferred pharmacy.

### Introducing Physician!
‘Physician’ is a desktop application that uses artificial intelligence (AI) to help doctors assess patients faster, diagnose their symptoms efficiently along with a voice automated notes feature.
This prototype has 3 main features. 
View Patient Data and x-ray Diagnosis
In this, the patient information is pulled and their X-ray scan is interpreted and diagnosed, typically what a radiologist does (for now, the focus is on tuberculosis detection). 
Symptom checker - Determining a diagnosis through appropriate symptom detection. 
Here, the doctors will analyze patient health issues by accessing their symptoms and can come up with a course of action based on the diagnosis.

Voice automated notes 
Doctors who are eventful all the time, can use this feature to capture the electronic health records for each patient they visit via a voice activated system. This alleviates the documentation burden from the physicians. 

