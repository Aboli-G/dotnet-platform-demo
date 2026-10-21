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

        stage('Restore') {
            steps {
                echo 'Restoring .NET dependencies'
                sh 'dotnet restore OilGas.Platform.slnx'
            }
        }

         stage('Build') {
            steps {
                 echo 'Building .NET solution'
                 sh 'dotnet build OilGas.Platform.slnx --configuration Release --no-restore'
             }  
         } 

        stage('Test') {
            steps {
                echo 'Dot net solution testing started'
                sh 'dotnet test OilGas.Platform.slnx --configuration Release --no-build'
            }
        }

        stage('Publish') {
            steps {
                echo 'Started publishing OilGas API'
                sh 'dotnet publish OilGas.Api/OilGas.Api.csproj --configuration Release --no-build --output OilGas.Api/publish'
            }
        }

        
        stage('Package Artifact') {
            steps {
                echo 'Packaging published application'
                sh 'tar -czf OilGas.Api/publish.zip -C OilGas.Api/publish .'
            }
        }


        stage('Archiving Artifacts') {
            steps {
                echo 'Archiving deployment artifact'
                archiveArtifacts artifacts: 'OilGas.Api/publish/**, OilGas.Api/publish.zip', fingerprint: true
            }
        }
    }

    post {
       
        success {
            echo 'CI pipeline completed successfully'
        }

        failure {
            echo 'CI pipeline failed'
        }

        always {
            echo 'Pipeline execution completed'
        }

    }
}
