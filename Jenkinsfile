pipeline {
    agent any

    stages {

        stage('Checkout') {
            steps {
                echo 'Code checkout stage started'
                sh 'pwd'
                sh 'ls -la'
            }
        }

        stage('Build') {
            steps {
                echo 'Build stage started'
                sh 'echo Simulating build process'
                sh 'echo Build successful'
            }
        }

        stage('Test') {
            steps {
                echo 'Test stage started'
                sh 'echo Running sample tests'
                sh 'echo All tests passed'
            }
        }
    }

    post {
        always {
            echo 'Pipeline execution completed'
        }
        success {
            echo 'Build succeeded'
        }
        failure {
            echo 'Build failed'
        }
    }
}
