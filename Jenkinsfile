pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'echo Build Stage'
        git(url: 'https://github.com/charan-k/DotNetOopsConcepts.git', branch: 'main', credentialsId: '196cbe21-0cab-439d-8bbc-adc1b16df1ef')
      }
    }

    stage('Test') {
      parallel {
        stage('Test') {
          steps {
            echo 'echo Test Stage'
            sh '''echo test
'''
          }
        }

        stage('Package') {
          steps {
            echo 'echo Package'
            sh 'echo package'
          }
        }

      }
    }

  }
}