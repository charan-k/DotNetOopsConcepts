pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        echo 'echo Build Stage'
      }
    }

    stage('Test') {
      parallel {
        stage('Test') {
          steps {
            echo 'echo Test Stage'
          }
        }

        stage('Package') {
          steps {
            echo 'echo Package'
          }
        }

      }
    }

  }
}