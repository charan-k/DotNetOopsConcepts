pipeline {
    agent any

    stages {
        stage('Build') 
        {
            steps {
                git branch: 'main', credentialsId: '196cbe21-0cab-439d-8bbc-adc1b16df1ef', url: 'https://github.com/charan-k/DotNetOopsConcepts.git'
            }
        }
		post
		{
		 success
		 {
		 emailext body: 'This is email body', subject: 'This is email subject', to: 'induricharan@gmail.com'
		 }
        
        }
     }
    }
